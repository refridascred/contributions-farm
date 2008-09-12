-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (token, weight, count) VALUES ('latest', 2.47, 2);
INSERT INTO layout_items (token, weight, count) VALUES ('local', 85.7, 70);
INSERT INTO layout_items (token, weight, count) VALUES ('eu-west', 56.35, 12);
