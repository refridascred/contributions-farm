-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, score, ratio) VALUES ('local', 72.27, 46.66);
INSERT INTO layout_items (label, score, ratio) VALUES ('blue', 15.07, 69.3);
