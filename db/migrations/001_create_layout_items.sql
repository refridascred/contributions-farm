-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (level, score, region) VALUES (75, 79.02, 'standard');
INSERT INTO layout_items (level, score, region) VALUES (58, 83.58, 'cached');
INSERT INTO layout_items (level, score, region) VALUES (7, 63.22, 'staging');
