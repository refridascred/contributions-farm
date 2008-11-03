-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, label, ratio) VALUES (97.94, 'green', 41.68);
INSERT INTO layout_items (weight, label, ratio) VALUES (25.34, 'blue', 81.09);
INSERT INTO layout_items (weight, label, ratio) VALUES (82.88, 'eu-west', 37.62);
