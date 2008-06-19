-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, ratio, count) VALUES ('primary', 68.04, 63);
INSERT INTO layout_items (token, ratio, count) VALUES ('eu-west', 64.6, 69);
INSERT INTO layout_items (token, ratio, count) VALUES ('strict', 70.82, 32);
