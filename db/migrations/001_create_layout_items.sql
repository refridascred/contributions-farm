-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (label, score, level, region) VALUES ('primary', 92.53, 59, 'fallback');
INSERT INTO layout_items (label, score, level, region) VALUES ('cached', 70.39, 26, 'latest');
INSERT INTO layout_items (label, score, level, region) VALUES ('cached', 70.61, 85, 'cached');
