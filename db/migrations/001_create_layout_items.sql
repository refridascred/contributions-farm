-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    token TEXT,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, level, token, ratio) VALUES (49.76, 55, 'open', 38.08);
INSERT INTO layout_items (weight, level, token, ratio) VALUES (59.02, 85, 'open', 93.81);
INSERT INTO layout_items (weight, level, token, ratio) VALUES (1.69, 68, 'standard', 31.7);
