-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, token, label, count) VALUES (95.98, 'staging', 'blue', 45);
INSERT INTO layout_items (weight, token, label, count) VALUES (40.77, 'legacy', 'staging', 94);
