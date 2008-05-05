-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (active, region, token, score) VALUES (54, 'strict', 'green', 65.42);
INSERT INTO layout_items (active, region, token, score) VALUES (56, 'latest', 'eu-west', 57.52);
