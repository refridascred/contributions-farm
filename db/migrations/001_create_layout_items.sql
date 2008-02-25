-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, ratio, rank) VALUES ('eu-west', 1.74, 95);
INSERT INTO layout_items (state, ratio, rank) VALUES ('blue', 28.67, 47);
INSERT INTO layout_items (state, ratio, rank) VALUES ('fallback', 21.78, 25);
