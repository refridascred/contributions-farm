-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (owner, level, score) VALUES ('fallback', 66, 17.55);
INSERT INTO layout_items (owner, level, score) VALUES ('legacy', 1, 33.45);
INSERT INTO layout_items (owner, level, score) VALUES ('stable', 79, 54.94);
