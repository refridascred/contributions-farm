-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (state, count, score) VALUES ('eu-west', 24, 8.34);
INSERT INTO layout_items (state, count, score) VALUES ('legacy', 18, 9.69);
INSERT INTO layout_items (state, count, score) VALUES ('standard', 95, 76.26);
