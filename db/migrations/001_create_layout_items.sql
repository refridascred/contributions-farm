-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, weight, owner, region) VALUES (21.73, 32.68, 'green', 'open');
INSERT INTO layout_items (score, weight, owner, region) VALUES (14.63, 54.48, 'latest', 'latest');
