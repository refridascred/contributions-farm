-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, region, owner, score, ratio) VALUES ('primary', 'standard', 'local', 46.09, 62.28);
INSERT INTO layout_items (state, region, owner, score, ratio) VALUES ('standard', 'primary', 'legacy', 91.03, 83.87);
INSERT INTO layout_items (state, region, owner, score, ratio) VALUES ('stable', 'cached', 'cached', 81.72, 56.46);
