-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (label, token, region, owner, ratio) VALUES ('strict', 'local', 'fallback', 'eu-west', 92.54);
INSERT INTO layout_items (label, token, region, owner, ratio) VALUES ('primary', 'open', 'eu-west', 'staging', 87.58);
INSERT INTO layout_items (label, token, region, owner, ratio) VALUES ('latest', 'eu-west', 'edge', 'blue', 6.13);
