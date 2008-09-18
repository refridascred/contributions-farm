-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, weight, ratio) VALUES ('fallback', 61.33, 46.3);
INSERT INTO layout_items (owner, weight, ratio) VALUES ('stable', 52.09, 39.38);
