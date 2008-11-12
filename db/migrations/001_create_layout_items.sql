-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, active, label, state, count) VALUES ('strict', 99, 'staging', 'standard', 84);
INSERT INTO layout_items (owner, active, label, state, count) VALUES ('stable', 74, 'eu-west', 'staging', 49);
INSERT INTO layout_items (owner, active, label, state, count) VALUES ('blue', 90, 'edge', 'green', 75);
