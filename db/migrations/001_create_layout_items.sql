-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, score, ratio) VALUES ('staging', 59.61, 31.7);
INSERT INTO layout_items (state, score, ratio) VALUES ('eu-west', 39.25, 47.45);
INSERT INTO layout_items (state, score, ratio) VALUES ('strict', 25.44, 1.74);
