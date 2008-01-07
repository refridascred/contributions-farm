-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, score, ratio, weight) VALUES ('legacy', 53.45, 70.26, 86.26);
INSERT INTO layout_items (state, score, ratio, weight) VALUES ('strict', 64.03, 96.96, 58.28);
