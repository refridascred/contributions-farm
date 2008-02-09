-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, score, active, token, region) VALUES (51, 97.55, 39, 'standard', 'primary');
INSERT INTO layout_items (level, score, active, token, region) VALUES (53, 30.04, 46, 'stable', 'eu-west');
