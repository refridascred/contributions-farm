-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (owner, score, level) VALUES ('open', 41.97, 70);
INSERT INTO layout_items (owner, score, level) VALUES ('green', 41.7, 45);
INSERT INTO layout_items (owner, score, level) VALUES ('local', 80.13, 67);
