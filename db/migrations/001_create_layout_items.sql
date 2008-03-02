-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (state, score, level, ratio) VALUES ('latest', 3.52, 95, 10.99);
INSERT INTO layout_items (state, score, level, ratio) VALUES ('strict', 50.4, 71, 72.41);
