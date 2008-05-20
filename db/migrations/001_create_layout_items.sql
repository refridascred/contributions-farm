-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (weight, owner, active) VALUES (55.69, 'staging', 98);
INSERT INTO layout_items (weight, owner, active) VALUES (52.06, 'edge', 13);
INSERT INTO layout_items (weight, owner, active) VALUES (89.02, 'staging', 56);
