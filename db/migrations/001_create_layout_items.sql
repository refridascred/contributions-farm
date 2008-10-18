-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, score, count) VALUES ('strict', 53.4, 39);
INSERT INTO layout_items (owner, score, count) VALUES ('cached', 42.4, 97);
INSERT INTO layout_items (owner, score, count) VALUES ('open', 84.41, 82);
