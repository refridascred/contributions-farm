-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, level, ratio, score, count) VALUES ('cached', 11, 72.79, 11.67, 72);
INSERT INTO layout_items (state, level, ratio, score, count) VALUES ('strict', 64, 58.43, 32.17, 34);
INSERT INTO layout_items (state, level, ratio, score, count) VALUES ('standard', 99, 22.08, 33.1, 65);
