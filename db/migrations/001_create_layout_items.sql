-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, score, token) VALUES ('green', 95.9, 'latest');
INSERT INTO layout_items (region, score, token) VALUES ('fallback', 33.82, 'staging');
INSERT INTO layout_items (region, score, token) VALUES ('standard', 70.69, 'latest');
