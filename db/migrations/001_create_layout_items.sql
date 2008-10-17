-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (rank, owner, active) VALUES (80, 'staging', 36);
INSERT INTO layout_items (rank, owner, active) VALUES (31, 'blue', 41);
INSERT INTO layout_items (rank, owner, active) VALUES (25, 'eu-west', 60);
