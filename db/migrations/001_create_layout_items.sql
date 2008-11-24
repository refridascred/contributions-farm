-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, label, score) VALUES ('open', 'standard', 94.47);
INSERT INTO layout_items (region, label, score) VALUES ('legacy', 'cached', 37.43);
