-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (label, ratio, weight) VALUES ('standard', 86.38, 18.93);
INSERT INTO layout_items (label, ratio, weight) VALUES ('green', 83.86, 64.17);
INSERT INTO layout_items (label, ratio, weight) VALUES ('edge', 85.55, 50.88);
