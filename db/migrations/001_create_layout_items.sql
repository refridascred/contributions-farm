-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, score, region) VALUES ('strict', 73.03, 'fallback');
INSERT INTO layout_items (label, score, region) VALUES ('cached', 40.51, 'blue');
