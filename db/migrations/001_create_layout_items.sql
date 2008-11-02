-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (label, ratio, weight) VALUES ('cached', 14.69, 70.63);
INSERT INTO layout_items (label, ratio, weight) VALUES ('cached', 86.05, 84.32);
