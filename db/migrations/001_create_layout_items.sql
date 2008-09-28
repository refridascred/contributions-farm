-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (level, label, region, score, state) VALUES (34, 'edge', 'edge', 98.63, 'legacy');
INSERT INTO layout_items (level, label, region, score, state) VALUES (24, 'open', 'blue', 0.56, 'eu-west');
INSERT INTO layout_items (level, label, region, score, state) VALUES (73, 'cached', 'green', 19.95, 'legacy');
