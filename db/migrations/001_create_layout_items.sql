-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, region, ratio, state) VALUES ('eu-west', 'local', 10.02, 'stable');
INSERT INTO layout_items (owner, region, ratio, state) VALUES ('strict', 'stable', 68.03, 'latest');
INSERT INTO layout_items (owner, region, ratio, state) VALUES ('edge', 'local', 64.88, 'latest');
