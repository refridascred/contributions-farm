-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (level, score, region, state) VALUES (62, 72.74, 'eu-west', 'green');
INSERT INTO layout_items (level, score, region, state) VALUES (37, 72.93, 'fallback', 'standard');
INSERT INTO layout_items (level, score, region, state) VALUES (80, 8.56, 'open', 'open');
