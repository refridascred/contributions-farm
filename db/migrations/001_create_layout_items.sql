-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, label, level, score) VALUES ('local', 'standard', 14, 33.07);
INSERT INTO layout_items (region, label, level, score) VALUES ('latest', 'staging', 51, 79.26);
