-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, owner, active, count) VALUES (16.07, 'cached', 61, 24);
INSERT INTO layout_items (weight, owner, active, count) VALUES (80.59, 'staging', 97, 0);
INSERT INTO layout_items (weight, owner, active, count) VALUES (4.69, 'strict', 84, 5);
