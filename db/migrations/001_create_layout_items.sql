-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (score, active, region) VALUES (49.14, 92, 'local');
INSERT INTO layout_items (score, active, region) VALUES (22.27, 57, 'blue');
INSERT INTO layout_items (score, active, region) VALUES (72.51, 18, 'legacy');
