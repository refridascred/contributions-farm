-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, weight, token, score, state) VALUES ('primary', 65.92, 'open', 27.07, 'edge');
INSERT INTO layout_items (region, weight, token, score, state) VALUES ('local', 80.43, 'staging', 32.93, 'cached');
