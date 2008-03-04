-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (score, label, level, region, state) VALUES (61.07, 'strict', 11, 'stable', 'cached');
INSERT INTO layout_items (score, label, level, region, state) VALUES (55.96, 'staging', 45, 'latest', 'primary');
INSERT INTO layout_items (score, label, level, region, state) VALUES (80.91, 'green', 57, 'open', 'fallback');
