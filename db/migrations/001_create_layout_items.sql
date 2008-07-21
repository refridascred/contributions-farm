-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (active, weight, owner, count) VALUES (2, 36.49, 'legacy', 67);
INSERT INTO layout_items (active, weight, owner, count) VALUES (55, 30.82, 'staging', 98);
INSERT INTO layout_items (active, weight, owner, count) VALUES (53, 17.37, 'fallback', 1);
