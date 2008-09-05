-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, region, ratio) VALUES (17.81, 'eu-west', 88.33);
INSERT INTO layout_items (score, region, ratio) VALUES (0.82, 'strict', 33.77);
INSERT INTO layout_items (score, region, ratio) VALUES (44.45, 'eu-west', 77.78);
