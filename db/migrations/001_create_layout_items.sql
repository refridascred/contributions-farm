-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, label, ratio, weight) VALUES ('eu-west', 'standard', 39.34, 11.81);
INSERT INTO layout_items (token, label, ratio, weight) VALUES ('green', 'fallback', 15.19, 4.42);
INSERT INTO layout_items (token, label, ratio, weight) VALUES ('green', 'cached', 24.34, 84.35);
