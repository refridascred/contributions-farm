-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (level, region, score, state) VALUES (39, 'standard', 37.97, 'open');
INSERT INTO layout_items (level, region, score, state) VALUES (87, 'latest', 90.08, 'blue');
INSERT INTO layout_items (level, region, score, state) VALUES (80, 'fallback', 13.16, 'eu-west');
