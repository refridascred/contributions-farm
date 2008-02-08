-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, weight, ratio) VALUES ('standard', 80.61, 3.24);
INSERT INTO layout_items (token, weight, ratio) VALUES ('primary', 90.49, 24.15);
