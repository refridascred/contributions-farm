-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (state, score, region, level) VALUES ('blue', 58.42, 'standard', 82);
INSERT INTO layout_items (state, score, region, level) VALUES ('local', 33.82, 'legacy', 15);
INSERT INTO layout_items (state, score, region, level) VALUES ('eu-west', 49.0, 'cached', 57);
