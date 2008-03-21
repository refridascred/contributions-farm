-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, weight, ratio) VALUES ('strict', 34.62, 88.79);
INSERT INTO layout_items (token, weight, ratio) VALUES ('eu-west', 64.38, 93.16);
INSERT INTO layout_items (token, weight, ratio) VALUES ('stable', 76.02, 58.82);
