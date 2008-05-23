-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (region, score, ratio, token) VALUES ('stable', 53.88, 75.6, 'strict');
INSERT INTO layout_items (region, score, ratio, token) VALUES ('cached', 12.53, 53.62, 'staging');
INSERT INTO layout_items (region, score, ratio, token) VALUES ('stable', 43.63, 57.44, 'strict');
