-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (owner, score, region) VALUES ('standard', 23.89, 'fallback');
INSERT INTO layout_items (owner, score, region) VALUES ('green', 53.68, 'green');
INSERT INTO layout_items (owner, score, region) VALUES ('standard', 28.29, 'blue');
