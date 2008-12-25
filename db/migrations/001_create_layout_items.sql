-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, ratio, score, level) VALUES ('fallback', 0.5, 48.44, 49);
INSERT INTO layout_items (owner, ratio, score, level) VALUES ('legacy', 17.08, 94.4, 55);
