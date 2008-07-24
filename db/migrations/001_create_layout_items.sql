-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, score, region) VALUES ('standard', 1.24, 'legacy');
INSERT INTO layout_items (label, score, region) VALUES ('blue', 76.46, 'strict');
INSERT INTO layout_items (label, score, region) VALUES ('fallback', 26.81, 'green');
