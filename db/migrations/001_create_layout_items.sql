-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, owner, level, label, region) VALUES (93.44, 'open', 11, 'strict', 'staging');
INSERT INTO layout_items (score, owner, level, label, region) VALUES (95.27, 'eu-west', 69, 'green', 'fallback');
