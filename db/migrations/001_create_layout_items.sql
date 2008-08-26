-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, ratio, region, active, state) VALUES (88.13, 3.13, 'standard', 22, 'staging');
INSERT INTO layout_items (score, ratio, region, active, state) VALUES (31.03, 92.62, 'green', 60, 'primary');
