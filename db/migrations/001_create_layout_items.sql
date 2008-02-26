-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, rank, active, region, label) VALUES (28.37, 39, 64, 'latest', 'staging');
INSERT INTO layout_items (score, rank, active, region, label) VALUES (96.78, 72, 54, 'cached', 'fallback');
