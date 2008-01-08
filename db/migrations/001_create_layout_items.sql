-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (count, owner, active, weight) VALUES (42, 'staging', 33, 46.56);
INSERT INTO layout_items (count, owner, active, weight) VALUES (98, 'local', 23, 89.92);
INSERT INTO layout_items (count, owner, active, weight) VALUES (26, 'fallback', 6, 31.14);
