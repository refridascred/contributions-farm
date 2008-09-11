-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, score, state, level) VALUES (40.75, 47.78, 'local', 44);
INSERT INTO layout_items (ratio, score, state, level) VALUES (21.27, 53.28, 'primary', 66);
INSERT INTO layout_items (ratio, score, state, level) VALUES (76.77, 23.22, 'strict', 67);
