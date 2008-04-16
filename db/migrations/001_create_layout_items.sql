-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, level, score, region) VALUES ('staging', 28, 44.24, 'blue');
INSERT INTO layout_items (label, level, score, region) VALUES ('stable', 53, 71.85, 'open');
INSERT INTO layout_items (label, level, score, region) VALUES ('eu-west', 16, 8.79, 'green');
