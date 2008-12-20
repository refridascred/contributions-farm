-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, weight, label, ratio) VALUES ('edge', 63.89, 'primary', 53.75);
INSERT INTO layout_items (token, weight, label, ratio) VALUES ('fallback', 80.34, 'strict', 81.28);
INSERT INTO layout_items (token, weight, label, ratio) VALUES ('latest', 33.66, 'edge', 53.97);
