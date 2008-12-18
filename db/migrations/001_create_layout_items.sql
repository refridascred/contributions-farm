-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (region, level, score, label) VALUES ('legacy', 20, 23.85, 'staging');
INSERT INTO layout_items (region, level, score, label) VALUES ('strict', 36, 12.67, 'fallback');
INSERT INTO layout_items (region, level, score, label) VALUES ('stable', 54, 37.48, 'legacy');
