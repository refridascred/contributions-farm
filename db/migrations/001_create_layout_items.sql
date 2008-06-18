-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    token TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (weight, owner, token, active) VALUES (86.03, 'local', 'green', 51);
INSERT INTO layout_items (weight, owner, token, active) VALUES (94.7, 'fallback', 'cached', 49);
INSERT INTO layout_items (weight, owner, token, active) VALUES (20.06, 'cached', 'edge', 37);
