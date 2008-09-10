-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, level, region, weight) VALUES (49.89, 5, 'primary', 17.57);
INSERT INTO layout_items (score, level, region, weight) VALUES (87.71, 53, 'staging', 12.06);
INSERT INTO layout_items (score, level, region, weight) VALUES (11.14, 37, 'eu-west', 19.62);
