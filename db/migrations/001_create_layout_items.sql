-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, token, count, ratio) VALUES (63.39, 'eu-west', 53, 12.89);
INSERT INTO layout_items (weight, token, count, ratio) VALUES (65.03, 'strict', 63, 35.95);
