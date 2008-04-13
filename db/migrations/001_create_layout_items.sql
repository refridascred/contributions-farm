-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, ratio, weight, count) VALUES ('latest', 0.76, 96.49, 24);
INSERT INTO layout_items (owner, ratio, weight, count) VALUES ('legacy', 93.3, 26.54, 28);
INSERT INTO layout_items (owner, ratio, weight, count) VALUES ('latest', 92.14, 98.57, 33);
