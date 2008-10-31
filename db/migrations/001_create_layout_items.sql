-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    token TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, token, label, ratio) VALUES (55.95, 'strict', 'latest', 28.95);
INSERT INTO layout_items (weight, token, label, ratio) VALUES (93.72, 'open', 'green', 93.33);
INSERT INTO layout_items (weight, token, label, ratio) VALUES (85.96, 'strict', 'staging', 84.49);
