-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, owner, score) VALUES (96, 'standard', 5.34);
INSERT INTO layout_items (level, owner, score) VALUES (17, 'eu-west', 50.24);
INSERT INTO layout_items (level, owner, score) VALUES (0, 'fallback', 37.9);
