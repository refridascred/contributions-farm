-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    label TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (state, owner, label, rank, active) VALUES ('blue', 'edge', 'blue', 84, 38);
INSERT INTO layout_items (state, owner, label, rank, active) VALUES ('edge', 'primary', 'green', 59, 43);
INSERT INTO layout_items (state, owner, label, rank, active) VALUES ('edge', 'eu-west', 'latest', 85, 15);
